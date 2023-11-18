using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
	public class YoutubeApi
	{
		public List<Video> GetVideos(string user)
		{
			try
			{
				throw new Exception("Opps some low level Youtube error");

			}
			catch (Exception ex)
			{

				throw new Exception("Could not fetch the youtube videos", ex);
			}

			return new List<Video>();
		}
	}
}
