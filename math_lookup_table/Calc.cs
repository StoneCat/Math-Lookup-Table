/*
 * Created by SharpDevelop.
 * User: Garfield
 * Date: 17.09.2016
 * Time: 00:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace math_lookup_table
{
	/// <summary>
	/// Description of Calc.
	/// </summary>
	public class Calc
	{
		public Calc()
		{
			//Nothing yet
		}
		
		public static int calculate_data_f_x_with_plus (int input_x, int x, int input_b)
		{
			return (input_x * x) + input_b;
		}
		
		public static int calculate_data_f_x_with_minus (int input_x, int x, int input_b)
		{
			return (input_x * x) - input_b;
		}
	}
}
