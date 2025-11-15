<<<<<<< HEAD
namespace SportsStore.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => 
            (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
=======
namespace SportsStore.Models.ViewModels {
  public class PagingInfo {
    public int TotalItems { get; set; }
    public int ItemsPerPage { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPages =>
      (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
  } 
>>>>>>> 607b160783a639cf95a18df2d91ab140a3189446
}