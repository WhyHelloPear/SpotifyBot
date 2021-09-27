using SpotifyAPI.Web;
using System;
using System.Threading.Tasks;

namespace SpotifyBot
{
    class SpotifyHandler
    {
        private string _token;
        public SpotifyClient _client;

        public SpotifyHandler( string token )
        {
            _token = token;
            _client = new SpotifyClient( token );
        }

        public async Task GetTrack( string trackId )
        {
            FullTrack track = await _client.Tracks.Get( trackId );
            Console.WriteLine( track.Name );
        }

    }
}
