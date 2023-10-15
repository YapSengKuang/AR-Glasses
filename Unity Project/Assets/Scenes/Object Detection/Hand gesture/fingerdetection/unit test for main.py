import unittest
import cv2
from cvzone.HandTrackingModule import HandDetector
from your_module import process_image  # Import your code that contains the main logic

class TestHandDetection(unittest.TestCase):
    def setUp(self):
        self.detector = HandDetector(detectionCon=0.8, maxHands=2)

    def test_hand_detection(self):
        cap = cv2.VideoCapture(0)
        cap.set(3, 1280)
        cap.set(4, 720)
        success, img = cap.read()
        hands, img = self.detector.findHands(img)  # with draw
        self.assertTrue(len(hands) > 0)

    def test_process_image(self):
        cap = cv2.VideoCapture(0)
        cap.set(3, 1280)
        cap.set(4, 720)
        success, img = cap.read()
        h, w, _ = img.shape
        detector = HandDetector(detectionCon=0.8, maxHands=2)
        sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
        serverAddressPort = ("127.0.0.1", 5052)

        # Mock the socket sendto method
        def mock_sendto(data, address):
            pass

        sock.sendto = mock_sendto

        result = process_image(img, detector, h, w, sock, serverAddressPort)
        self.assertTrue(result)  # Replace this with an appropriate assertion

if __name__ == "__main__":
    unittest.main()
