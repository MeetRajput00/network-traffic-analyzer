import pyshark                  #to use wireshark dissectors and packet sniffing

#start with packet sniffing
def capture_packets():
    capture=pyshark.LiveCapture()
    capture.sniff(timeout=50)


#main method
if(__name__=="__main__"):
    capture_packets()