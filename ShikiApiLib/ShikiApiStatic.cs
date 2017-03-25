using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShikiApiLib
{
    public static class ShikiApiStatic
    {
        public static string Domen { get { return "https://shikimori.org/"; } }
        public static string DomenApi { get { return "https://shikimori.org/api/"; } }
        public static string ClientName { get; set; } = "Shiki Desktop App";

        private const int rate_list_limit = 999999;

        public static UserInfo GetUserInfo(int user_id)
        {
            string url = DomenApi + "users/" + user_id;
            return new UserInfo(Query.GET<_UserFullInfo>(url));
        }

        public static List<AnimeRate> GetAnimeRates(int user_id, int limit = rate_list_limit)
        {
            string url = DomenApi + "users/" + user_id + "/anime_rates?limit=" + limit;
            return Query.GET<List<_UserRate>>(url).Select(x => new AnimeRate(x)).ToList();
        }

        public static List<MangaRate> GetMangaRates(int user_id, int limit = rate_list_limit)
        {
            string url = DomenApi + "users/" + user_id + "/manga_rates?limit=" + limit;
            return Query.GET<List<_UserRate>>(url).Select(x => new MangaRate(x)).ToList();
        }

        public static AnimeFullInfo GetAnimeFullInfo(int id)
        {
            string url = DomenApi + "animes/" + id;
            return Query.GET<AnimeFullInfo>(url);
        }

        public static MangaFullInfo GetMangaFullInfo(int id)
        {
            string url = DomenApi + "mangas/" + id;
            return Query.GET<MangaFullInfo>(url);
        }

        public static List<Studio> GetStudios()
        {
            string url = DomenApi + "studios";
            return Query.GET<List<Studio>>(url);
        }

        public static Studio GetStudio(int id)
        {
            return GetStudios().FirstOrDefault(x => x.id == id);
        }

        public static List<Studio> GetPublishers()
        {
            string url = DomenApi + "publishers";
            return Query.GET<List<Studio>>(url);
        }

        public static Studio GetPublisher(int id)
        {
            return GetPublishers().FirstOrDefault(x => x.id == id);
        }

        public static List<Genre> GetGenres()
        {
            string url = DomenApi + "genres";
            return Query.GET<List<Genre>>(url);
        }

        public static Genre GetGenre(int id)
        {
            return GetGenres().FirstOrDefault(x => x.id == id);
        }

        public static List<Video> GetVideos(int title_id) //Video of animes (OP or ED)
        {
            string url = DomenApi + "animes/" + title_id + "/videos";
            return Query.GET<List<Video>>(url);
        }
    }
}