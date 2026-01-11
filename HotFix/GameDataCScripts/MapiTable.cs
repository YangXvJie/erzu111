using System.Collections;
using System.Collections.Generic;
using W.GameFrameWork.ExcelTool;
/*
* Author:W
* Excel表转换生成
* MapiTable
*/
namespace HotFix
{
	[System.Serializable]
	public class MapiTableParSer
	{
		public List<MapiTable> data = new List<MapiTable>();
		public List<MapiTable> Data
		{
			get
			{
				return data;
			} 
		}	} 
	[System.Serializable]
	public class MapiTable:ExcelItem
	{
	/// <summary>
	/// 类型编号
	/// <summary>
	public string MapNum;
	/// <summary>
	/// 类型名称
	/// <summary>
	public string MapName;

	}
}