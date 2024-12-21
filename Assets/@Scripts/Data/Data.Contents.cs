using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Data
{
	#region TestData
	[Serializable]
	public class TestData
	{
		public int Level;
		public int Exp;
		public List<int> Skills;
		public float Speed;
		public string Name;
	}

	[Serializable]
	public class TestDataLoader : ILoader<int, TestData>
	{
		public List<TestData> tests = new List<TestData>();

		public Dictionary<int, TestData> MakeDict()
		{
			Dictionary<int, TestData> dict = new Dictionary<int, TestData>();
			foreach (TestData testData in tests)
				dict.Add(testData.Level, testData);

			return dict;
		}
	}
    #endregion

    #region BlockData
    public class BlockData
    {
        public int DataID;
        public string Name;
		public bool pos1;
		public bool pos2;
		public bool pos3;
		public bool pos4;
		public bool pos5;
		public bool pos6;
		public bool pos7;
		public bool pos8;
		public bool pos9;
    }

    [Serializable]
    public class BlockDataLoader : ILoader<int, BlockData>
    {
        public List<BlockData> block = new List<BlockData>();

        public Dictionary<int, BlockData> MakeDict()
        {
            Dictionary<int, BlockData> dict = new Dictionary<int, BlockData>();
            foreach (BlockData blockData in block)
                dict.Add(blockData.DataID, blockData);

            return dict;
        }
    }
    #endregion
}