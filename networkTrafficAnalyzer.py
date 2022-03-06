from flask import request
import unicodedata
import pandas,numpy,matplotlib,pyshark  #to use wireshark dissectors and packet sniffing

blacklistIPS=[]

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

    #stores source and destination ip address over the network interface 
          
    for packets in capture.sniff_continuously(packet_count=20):
        if packets.ip.dst in blacklistIPS:
            print("{} interacted with a blacklisted IP.".format(packets.ip.src))
    



#main method
if(__name__=="__main__"):
    maliciousIPAddress()
    capture_packets()