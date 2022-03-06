from scapy.all import *

#sniff packets and store them in pktSniffed.pcap
capture=sniff(count=20)

wrpcap("pktSniffed.pcap",capture)
#pcap file created!
