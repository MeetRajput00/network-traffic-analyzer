from flask import request
import unicodedata
import pandas,numpy,matplotlib,pyshark  #to use wireshark dissectors and packet sniffing
import urllib
from tkinter import *
import tkinter as tk

blacklistIPS=[]
validIPS=['127.0.0.1','192.168.211.7','157.240.239.60']
srcIPS=set()
averageTraffic=5
#web crawler to get malicious ip address over the internet

def maliciousIPAddress():
    df=pandas.read_html("https://www.projecthoneypot.org/list_of_ips.php?ctry=IN")
    df=df[0]
    ipColumn=df[0]
    ipColumn.str.split().str.join(' ')
    for ips in ipColumn.values:
        try:
            ip,whatever=ips.split("|")
            newIP=unicodedata.normalize("NFKD",ip).strip()
            blacklistIPS.append(newIP)
        except:
            pass

#start with packet sniffing

def capture_packets():
    capture=pyshark.LiveCapture()
    capture.sniff(timeout=20)
    count=0
    #stores source and destination ip address over the network interface 
    print("No.\tTime\tSource\t\tDestination\t\tProtocol")
    for packet in capture:
        try:
            print("{}{}{}{}{}".format(count,packet.delta,packet.source,packet.destination,packet.protocol))
            count+=1
            srcIPS.add(packet.ip.src)
            if(len(srcIPS)>averageTraffic):
                print("You were getting more traffic than usual.")
                break
            if packet.ip.src not in validIPS:
                print("{} is not a registered IP.".format(packet.ip.src))
            if packet.ip.dst in blacklistIPS:
                print("{} interacted with a blacklisted IP.".format(packet.ip.src))
        except:
            pass
    


#main method
if(__name__=="__main__"):
    root=Tk()
    root.title("Network Traffic Analyzer")
    root.geometry('600x400')

    statusbar = tk.Label(root, text="Application running.", bd=1, relief=tk.SUNKEN, anchor=tk.W)
    statusbar.pack(side=tk.BOTTOM, fill=tk.X)
    
    root.mainloop()