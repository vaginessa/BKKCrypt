import unittest
from BKKCrypt import BKKCrypt
import urllib.request

class TestEncodeStrings(unittest.TestCase):

    def test_simple_strings(self):
        self.assertEqual(BKKCrypt('adminadmin'), 'adminadmin')
        self.assertEqual(BKKCrypt('hunter2'), 'hunter2')
        self.assertEqual(BKKCrypt('password'), 'password')

    def test_PIN_numbers(self):
        self.assertEqual(BKKCrypt(1234), 1234)
        self.assertEqual(BKKCrypt('1234'), '1234')
        self.assertEqual(BKKCrypt(6969), 6969)
        self.assertEqual(BKKCrypt('6969'), '6969')
     
    def test_empty_passwords(self):
        self.assertEqual(BKKCrypt(''), '')


class TestBLNS(unittest.TestCase):
    """Test strings from https://github.com/minimaxir/big-list-of-naughty-strings/"""

    blns_request = urllib.request.urlretrieve("https://raw.githubusercontent.com/minimaxir/big-list-of-naughty-strings/master/blns.txt")
    with open(blns_request[0]) as blns_file:
        blns = blns_file.readlines()

    def test_blns_lines(self):
        for line in self.blns:
            with self.subTest(line=line):
                self.assertEqual(BKKCrypt(line), line)

if __name__ == '__main__':
    unittest.main()
