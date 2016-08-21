[Flags]
public enum SecurityFlag : byte
{
	None = 0,
	Disabled = 1,
	Blowfish = 2,
	SecurityBytes = 4,
	Handshake = 8,
	HandshakeResponse = 16,
	UnkBit5 = 32,
	UnkBit6 = 64,
	UnkBit7 = 128
}