void Start () {

		int a = 0;
		for (int i = 0; i < 33; i++) {
			a = setBit (a, 1, i);
			printBitMode (a);
		}

	}

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
	public void printBitMode(int holder)
	{
		Debug.Log (Convert.ToString (holder, 2).PadLeft (8, '0') + "[" + holder + "]");	
	}
