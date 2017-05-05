using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Love_Bangumi
{
    class bangumiTimeLine
    {   
        private jsonCatcher timeLineJson = new jsonCatcher("http://bangumi.bilibili.com/api/timeline_v2_global", true);     //Bilibili API.
        private JToken timeLineData;

        public ArrayList TimeLine = new ArrayList();  //Timeline Array. 7 elements => 7 days of a week.
        private int bangumiCount;

        public bangumiTimeLine()
        {
            timeLineData = timeLineJson.json()["result"];
            bangumiCount = 2;

            ArrayList singleDayBangumi = new ArrayList();    //One day's all bangumi

            for (int i = 0; i < bangumiCount; i++)
            {
                DayOfWeek week = Convert.ToDateTime((string)timeLineData[bangumiCount]["lastupdate_at"]).DayOfWeek;    //0 -> Sunday. 6->Saturday.
                int weekNumber = (int)week;

                Dictionary<string, string> singleBangumi = new Dictionary<string, string>();    //Single Bangumi Infomation.
                singleBangumi.Add("Name",(string)timeLineData[bangumiCount]["title"]);
                singleBangumi.Add("Cover_URL",(string)timeLineData[bangumiCount]["cover"]);
                singleBangumi.Add("Season_ID",(string)timeLineData[bangumiCount]["season_id"]);
                singleBangumi.Add("WeekDay",weekNumber.ToString());
                //Don't use the week day info in the json.(weekday) It contains -1 value which means the weekday is not sure.

                singleBangumi.Add("Attention",(string)timeLineData[bangumiCount]["attention"]);
                singleBangumi.Add("Play_Count",(string)timeLineData[bangumiCount]["play_count"]);

                singleDayBangumi.Add(singleBangumi);
                //TimeLine[weekNumber] = singleDayBangumi;
                
            }
           // MessageBox.Show((string)((Dictionary<string,string>)singleDayBangumi[0])["Name"]);
          //  MessageBox.Show((string)((Dictionary<string,string>)singleDayBangumi[1])["Name"]);

        }

            //private static int timeStampToWeek(int timeStamp)
            //{
            //    DateTime defaultTime = new DateTime(1970, 1, 1, 0, 0, 0);
            //    long timeTick = defaultTime.Ticks + timeStamp * 10000;

            //    DateTime standardTime = new DateTime(timeTick);
            //    DayOfWeek week = Convert.ToDateTime(standardTime).DayOfWeek;    //0 -> Sunday. 6->Saturday.

            //    return (int)week;
            //}
        
    }
}
