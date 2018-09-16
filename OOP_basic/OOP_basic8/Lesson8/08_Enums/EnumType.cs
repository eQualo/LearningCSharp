using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Enums
{
	enum EnumType
	{
		Zero, 
		One,
		one= One,
		Two  = 2,
		Three,
		Four,
		Five,
		Six = Nine,
		//Seven
		Eight = 8,
		Nine,  
		Ten = 10,
		Infinite = 255
	}
}
