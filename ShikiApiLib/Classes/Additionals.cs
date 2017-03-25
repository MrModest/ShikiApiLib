using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShikiApiLib
{
    //Вспомогательные классы перечисления

    /// <include file='Docs/ExternalSummary.xml' path='docs/Enums/enum[@name="TitleType"]/*' />
    public enum TitleType { anime, manga }
    /// <include file='Docs/ExternalSummary.xml' path='docs/Enums/enum[@name="UserStatus"]/*' />
    public enum UserStatus { planned, watching, completed, on_hold, dropped, rewatching = 9 }
    /// <include file='Docs/ExternalSummary.xml' path='docs/Enums/enum[@name="Order"]/*' />
    public enum Order { ranked, popularity, name, aired_on, id }
    /// <include file='Docs/ExternalSummary.xml' path='docs/Enums/enum[@name="Rating"]/*' />
    public enum Rating { g, pg, pg_13, r, r_plus, rx }
    /// <include file='Docs/ExternalSummary.xml' path='docs/Enums/enum[@name="TitleStatus"]/*' />
    public enum TitleStatus { released, latest, ongoing, anons }
    /// <include file='Docs/ExternalSummary.xml' path='docs/Enums/enum[@name="AKind"]/*' />
    public enum AKind { tv, tv_13, tv_24, tv_48, movie, ova, ona, special }
    /// <include file='Docs/ExternalSummary.xml' path='docs/Enums/enum[@name="MKind"]/*' />
    public enum MKind { manga, manhwa, manhua, novel, one_shot, doujin }

    /// <summary>
    /// Продолжительность эпизода
    /// </summary>
    /// <include file='Docs/ExternalSummary.xml' path='docs/Enums/enum[@name="Duration"]/*' />
    public enum Duration
    {
        /// <summary>
        /// Эпизод до 10 минут
        /// </summary>
        S,
        /// <summary>
        /// Эпизод до 30 минут
        /// </summary>
        D,
        /// <summary>
        /// Эпизод более 30 минут
        /// </summary>
        F
    }

    public static class UserRateStatus
    {
        public static string Planned   { get { return "planned"; } }
        public static string Watching  { get { return "watching"; } }
        public static string Completed { get { return "completed"; } }
        public static string OnHold    { get { return "on_hold"; } }
        public static string Dropped   { get { return "dropped"; } }
    }

    public static class AnimeKind
    {
        public static string tv         { get { return "tv"; } }
        public static string tv_short   { get { return "tv_13"; } }
        public static string tv_average { get { return "tv_24"; } }
        public static string tv_long    { get { return "tv_48"; } }
        public static string movie      { get { return "movie"; } }
        public static string ova        { get { return "ova"; } }
        public static string ona        { get { return "ona"; } }
        public static string special    { get { return "special"; } }
        public static string music      { get { return "music"; } }
    }

    public static class MangaKind
    {
        public static string manga    { get { return "manga"; } }
        public static string manhwa   { get { return "manhwa"; } }
        public static string manhua   { get { return "manhua"; } }
        public static string novel    { get { return "novel"; } }
        public static string one_shot { get { return "one_shot"; } }
        public static string doujin   { get { return "doujin"; } }
    }
}
