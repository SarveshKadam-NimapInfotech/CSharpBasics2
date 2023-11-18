using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var api = new YoutubeApi();
				var videos = api.GetVideos("Mosh");

			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message); 
			}
		}
	}
}
