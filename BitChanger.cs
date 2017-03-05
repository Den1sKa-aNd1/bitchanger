// Function that is using binary operators to toggle or untoggle specific bit in the integer holder
// holder = integer variable that is holding the flags (0 or 1)
// value = parameter that specifies to what the bit position should be swithced (0 or 1)
// position = integer representation of the bit place that should be schanged (starting from 0)
public int setBit (int holder, int value, int position)
{
	switch (value) {
	case 1:
		return holder |= 1 << position;
	case 0:
		return holder &= ~(1 << position);
	default:
		return holder;
	}
}

//print out of the integer bits holder into string with required number of bits position
// holder = integer variable that is holding the flags (0 or 1)
// numberOfBits = parameter that specifies how many "useful" bit to show (how many bits are used in the int)
public void printBitMode(int holder,int numberOfBits)
{
	Debug.Log (Convert.ToString (holder, 2).PadLeft (numberOfBits, '0') + "[" + holder + "]");	
}
//print out of the integer bits holder into string with 16 positions in the int
// holder = integer variable that is holding the flags (0 or 1)
public void printBitMode(int holder)
{
	Debug.Log (Convert.ToString (holder, 2).PadLeft (16, '0') + "[" + holder + "]");	
}
//hod to use
