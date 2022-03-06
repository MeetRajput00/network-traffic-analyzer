from scapy.all import *

#sniff packets and store them in pktSniffed.pcap
def capture_packets():
    capture=sniff(count=20)

    wrpcap("pktSniffed.pcap",capture)
#pcap file created!

#analyze packets from pktSniffed.pcap

