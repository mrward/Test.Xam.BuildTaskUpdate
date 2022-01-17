using System;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Test.Xam.BuildTaskUpdate
{
	public class GetTasksAbi : Task
	{
		[Output]
		public string AbiVersion { get; } = "1";

		public override bool Execute ()
		{
			return true;
		}
	}
}

