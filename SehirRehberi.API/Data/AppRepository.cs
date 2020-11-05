using Microsoft.EntityFrameworkCore;
using SehirRehberi.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Data
{
    

    public class AppRepository : IAppRepository
    {
        private DataContext _context;
        public AppRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public List<City> GetCities()
        {
            var cities = _context.Cities.Include(c => c.Photos).ToList();
            return cities;
        }

        public City GetCityById(int cityId)
        {
            var city = _context.Cities.Include(c => c.Photos).FirstOrDefault(c => c.Id == cityId);
            return city;
        }

        public Photo GetPhoto(int id)
        {
            var photo = _context.Photos.FirstOrDefault(p => p.Id == id);
            return photo;

        }

        public List<Photo> GetPhotosByCity(int cityId)
        {
            var photos = _context.Photos.Where(p => p.CityId == cityId).ToList();
            return photos;
        }

        public List<Photo> GetPhotosByUserId(int userId)
        {
            var photos = _context.Photos.Where(p => p.UserId == userId).ToList();
            return photos;
        }

        public List<Comment> GetCommentsByPhoto(int photoId)
        {
            var comments = _context.Comments.Where(p => p.PhotoId == photoId).ToList();
            return comments;
        }

        public Rating GetCityRating(int cityId)
        {
            var rating = _context.Ratings.Where(p => p.CityId == cityId).FirstOrDefault();
            return rating;
        }




        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
