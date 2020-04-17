using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Crawl1._1
{
    class SimpleCrawl
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        private string starUrl;

        public SimpleCrawl(string start)
        {
            starUrl = start;
        }

        public void Crwal()
        {
            Console.WriteLine("开始爬虫");
            urls[starUrl] = false;
            while (true)
            {
                string current = null;
                foreach(string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                    break;
                }
                if (current == null || count >= 10) break;
                Console.WriteLine("爬行" + current + "页面");
                string html = DownLoad(current);
                urls[current] = true;
                count++;
                Parse(html);
                Console.WriteLine("爬行结束");

            }
        }

        public void PageCraw()
        {
            Console.WriteLine("爬虫开始");
            string html = DownLoad(starUrl);
            Parse(html);

            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                    Console.WriteLine("爬虫" + current);
                }
                Console.WriteLine("爬行结束");
                break;
            }

        }
        
        public void HtmlCraw()
        {
            Console.WriteLine("爬虫开始");
            string html = DownLoad(starUrl);
            HtmlParse(html);
            
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                    break;
                }
                if (current == null || count >= 10) break;
                count++;
                Console.WriteLine("爬取" + current + "页面");
                urls[current] = true;
                html = DownLoad(current);
                HtmlParse(html);
            }


        }

        public void relativeCraw()
        {
            Console.WriteLine("爬虫开始");
            string html = DownLoad(starUrl);
            relativeParse(starUrl, html);
            while (true)
            {
                string current = null;
                foreach(string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                    break;
                }
                if (current == null || count >= 500) break;
                count++;
                Console.WriteLine("爬取" + current + "页面");
                urls[current] = true;
                html = DownLoad(current);
                relativeParse(current, html);
            }
        }

        private void relativeParse(string url, string html)
        {
            string strRef = @"(href|HREF)[ ]*=[ ]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach(Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                    .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                strRef = match.Value.Substring(match.Value.IndexOf("=") + 1)
                    .Trim('"', '\'', '\"', '#', '>');
                if (strRef.StartsWith(".") || strRef.StartsWith("/"))
                {
                    while (strRef.StartsWith("../"))
                    {
                        strRef = strRef.Substring(3);
                        int index = url.LastIndexOf("/");
                        url = url.Substring(0, index);
                        index = url.LastIndexOf("/");
                        url = url.Substring(0, index);
                    }
                    while (strRef.StartsWith("/")) strRef = strRef.Substring(1);
                    strRef = url + strRef;
                }
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }

        private void HtmlParse(string html)
        {
            string strRef = @"(href|HREF)[ ]*=[ ]*[""'][^""'#>]+html[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach(Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf("=") + 1)
                    .Trim('"', '\"', '#', '>');            
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }

        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[ ]*=[ ]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach(Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf("=") + 1)
                    .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }

        private string DownLoad(string current)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(current);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch(Exception e )
            {
                Console.WriteLine(e.Message);
                return "";
            }
        }
    }
}
