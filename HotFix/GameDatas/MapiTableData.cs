using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotFix
{
    class MapiTableData
    {
        public string MapNum;
        public string MapName;

        public MapiTableData(string mapNum, string mapName)
        {
            MapNum = mapNum;
            MapName = mapName;
        }
        public class MapiTableDataSer
        {
            public List<MapiTableData> data = new List<MapiTableData>();
            public List<MapiTableData> Data
            {
                get
                {
                    return data;
                }
            }
        }
    }
}
