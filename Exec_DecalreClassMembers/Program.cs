using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DecalreClassMembers
{
	/// <summary>
	/// Exec_DeclareClassMembers
	/// 將指定文字內容存檔, 由於要存放的文字內容與檔案存放位置都會變化, 
	/// 所以我們可以將這兩項資訊設計成 method的參數, 
	/// 由外界傳入請設計一個FileManager class, 
	/// 內含一個 Save method只需要設定method, 不必實作出功能
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			FileManager manager = new FileManager();
			string fileName = "hahaha";
			string fileLocation = @"d:\user\file\";
			manager.Save(fileName, fileLocation);
		}
	}

	class FileManager
	{
		private string fileName;
		private string fileLocation;
		public void Save(string fileName, string fileLocation)
		{
			//這裡可以存東西
		}
	}
}
