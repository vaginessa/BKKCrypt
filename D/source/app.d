import std.stdio;
import bkkcrypt;

void main()
{
	string encryptedPassword = bkkcrypt.bkkCrypt("password");
	writeln(encryptedPassword);
}
