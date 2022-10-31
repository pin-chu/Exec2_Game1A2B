using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Game1A2B
{
	public partial class Form1 : Form
	{
		

		public Form1()
		{
			InitializeComponent();
			

		}
		private void NewButton_Click(object sender, EventArgs e)
		{
			var game = new ABNumber();
			ShowTextBox.Text = game.NewGame();
		}

		private void CalcButton_Click(object sender, EventArgs e)
		{

			int a = 0, b = 0;
			string gnum = InputTextBox.Text;
			string answer = ShowTextBox.Text;
			
			char[] arr_gnum = gnum.ToCharArray();
			
			char[] arr_answer = answer.ToCharArray();
			for (int k = 0; k < 4; k++)
			{
				for (int p = 0; p < 4; p++)
				{
					if (arr_gnum[k] == arr_answer[p])
					{
						if (k == p)
						{
							a++;
						}
						else if (k != p)
						{
							b++;
						}

					}

				}
			}
			MessageBox.Show(a.ToString()+"A"+b.ToString()+"B");
		}

	}
	
	public class ABNumber
		{
			private string answer { get; set; }
			private bool check_str { get; set; }//布林宣告check_str，判斷數字是否重複
			public string NewGame() 
			{
				check_str = false;//預設false
				var random = new Random();
				answer = random.Next(1000, 9999).ToString();//亂數1000-9999
				check_str = Check_num(answer);//檢查亂數4碼是否重複
				while (check_str == false)//當有重複時，check_str 會為false，則需重取亂數並檢查，直到沒重複為止
				{
					answer = random.Next(1000, 9999).ToString();
					check_str = Check_num(answer);
				}
				return answer;
			}
			public bool Check_num(string str)
			{
				char[] arr_str = str.ToCharArray();
				if (arr_str[0] == arr_str[1] || arr_str[0] == arr_str[2] || arr_str[0] == arr_str[3] || arr_str[1] == arr_str[2] || arr_str[1] == arr_str[3] || arr_str[2] == arr_str[3])
				{
					return false;
				}
				else 
				{
					return true;
				}
			}
		}
	}
