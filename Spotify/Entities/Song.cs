using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Entities
{
    internal class Song
    {
        public Guid Id { get; set; }    
        public string Title { get; set; }
        public string Composer { get; set; }
        public string Artist { get; set; }
        public string Producer { get; set; }
        
        
        public Song()
        {
            Id= Guid.NewGuid();
        }
        public Song(string title,string composer, string artist,string producer): this()
        {
            Title = title;
            Composer = composer;
            Artist = artist;
            Producer = producer;
            
        }
    }
}
