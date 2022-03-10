from flask import request
import unicodedata
import pandas,numpy,matplotlib,pyshark  #to use wireshark dissectors and packet sniffing
import urllib

class networkTrafficAnalyzer:
    blacklistIPS=[]
    validIPS=['127.0.0.1','192.168.211.7','157.240.239.60']
    srcIPS=set()
    averageTraffic=5
    count=0
    #web crawler to get malicious ip address over the internet

    def __init__(self):
        df=pandas.read_html("https://www.projecthoneypot.org/list_of_ips.php?ctry=IN")
        df=df[0]
        ipColumn=df[0]
        ipColumn.str.split().str.join(' ')
        for ips in ipColumn.values:
            try:
                ip,whatever=ips.split("|")
                newIP=unicodedata.normalize("NFKD",ip).strip()
                self.blacklistIPS.append(newIP)
            except:
                pass

    #start with packet sniffing

    def capture_packets(self):
        capture=pyshark.LiveCapture()
        #stores source and destination ip address over the network interface 
        for packet in capture.sniff_continuously():
            try:
                print(str(self.count)+" "+str(packet.sniff_time)+" "+str(packet['ip'].src)+" "+str(packet['ip'].dst)+" "+str(packet.highest_layer))
                self.count+=1
                # srcIPS.add(packet.ip.src)
                # if(len(srcIPS)>averageTraffic):
                #     print("You were getting more traffic than usual.")
                #     break
                # if packet.ip.src not in validIPS:
                #     print("{} is not a registered IP.".format(packet.ip.src))
                # if packet.ip.dst in blacklistIPS:
                #     print("{} interacted with a blacklisted IP.".format(packet.ip.src))
            except Exception as e:
                print(e)
    
