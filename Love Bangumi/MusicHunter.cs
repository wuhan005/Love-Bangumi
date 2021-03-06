﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Love_Bangumi
{
    class MusicHunter
    {
        public string bSongName;    //Bangumi Song's Name
        public string bSongURL;     //Bangumi Song's URL

        private string sWord;
        private jsonCatcher jsonData;
        private string media_mid;

        private string key_orginal = "233";
        private string key;

        private string music_url;

        public MusicHunter(string keyword)
        {
            //Get music media_mid
            sWord = keyword + " OP";    //Get the bangumi OP
            jsonData = new jsonCatcher("http://c.y.qq.com/soso/fcgi-bin/search_cp?p=1&n=3&w=" + keyword + "&aggr=1&lossless=1&cr=1",true);
            media_mid = (string)jsonData.json()["data"]["song"]["list"][1]["media_mid"];

            bSongName = (string)jsonData.json()["data"]["song"]["list"][1]["songname"];     //Get the song name
            bSongName = bSongName.Replace("(日语", "");                                    //Delete the useless word.

            //Get key
            jsonData = new jsonCatcher("https://c.y.qq.com/base/fcgi-bin/fcg_musicexpress.fcg?json=3&guid=" + key_orginal,true);
            key = (string)jsonData.json()["key"];

            music_url = "http://dl.stream.qqmusic.qq.com/M800" + media_mid + ".mp3?vkey=" + key + "&guid=" + key_orginal + "&fromtag=30";

            bSongURL = music_url;

            //System.Diagnostics.Process.Start(music_url);      //Open the music

            
        }
    }
}
