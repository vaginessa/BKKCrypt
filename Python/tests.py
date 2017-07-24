import unittest
from BKKCrypt import BKKCrypt

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


if __name__ == '__main__':
    unittest.main()
