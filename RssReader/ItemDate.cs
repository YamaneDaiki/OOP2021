using System;

namespace RssReader {
    internal class ItemDate {
        internal string Link;

        public string Title { get; internal set; }
        public string Description { get; internal set; }
        public DateTime PubDate { get; internal set; }
    }
}