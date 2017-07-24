package bkkcrypt

import "testing"

func TestSum(t *testing.T) {
	password := "verysecure"
	data := []byte(password)
	encrypted := Sum(data)
	if string(encrypted) != password {
		t.Errorf("Encrypted should be %s, instead of %s", password, encrypted)
	}
}
