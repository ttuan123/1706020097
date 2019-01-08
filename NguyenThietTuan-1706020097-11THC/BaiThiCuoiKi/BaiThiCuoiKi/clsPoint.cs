/*
 * Created by SharpDevelop.
 * User: C1-A01
 * Date: 1/8/2019
 * Time: 9:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BaiThiCuoiKi
{
	/// <summary>
	/// Description of clsPoint.
	/// </summary>
	public class clsPoint
	{
		int ix, iy;
		public int X
		{
			get{
				return X;
			}
			set{
				ix = value;
			}
		}
		public int Y
		{
			get{
				return Y;
			}
			set{
				iy = value;
			}
		}
		public clsPoint()
		{
			X = 0;
			Y = 0;
		}
		
		public clsPoint(int a, int b)
		{
			X = a;
			Y = b;
		}
	}
}
