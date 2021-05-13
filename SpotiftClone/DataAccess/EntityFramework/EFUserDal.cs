using SpotiftClone.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotiftClone.DataAccess
{
    class EFUserDal
    {
        private void createPlaylist(users user)
        {
            
            //int[] songTypeID = Connection.spotifydb.song_type
            var type = Connection.spotifydb.song_type.ToList();

            foreach (var item in type)
            {
                
                Connection.spotifydb.playlists.Add(new playlists() { userID = user.ID, songTypeID = item.ID });
            }


            //Connection.spotifydb.playlists.Add(new playlists() { userID = user.ID, songTypeID = songTypeID[i] });
        }



        public bool checkIfEmail(String email)
        {
            if (Connection.spotifydb.users.Where(c => c.mail == email).Count() > 0)
                return false;
            return true;
        }

        public users login(String email, String password)
        {
            return Connection.spotifydb.users.Where(c => c.mail == email && c.password == password).FirstOrDefault();
            
        }

        public bool checkIfAdmin(users user)
        {
           
            if (user != null && Connection.spotifydb.admins.Where(c => c.userID == user.ID).Count()>0 )
                return true;
            return false;
        }

        public void addUser(users user)
        {
            Connection.spotifydb.users.Add(user);
            createPlaylist(user);
            Connection.spotifydb.SaveChanges();
        }


    }
}
