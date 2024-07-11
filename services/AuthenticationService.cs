using EducationCentre.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationCentre.models;
using EducationCentre.context;
using EducationCentre.exception;
using BCrypt.Net;
namespace EducationCentre.services
{
    /**
     * @brief : A class that handles the authentication of the user
     */
    public class AuthenticationService
    {
        private readonly Repository<Profile> profileRepository;
        private readonly string salt = "$2a$04$z6b7Flr3i8.rglQIBi1u.OrIgQsjIFDWnJ5d2t0gbKAHVnAzHS7ma";

        public AuthenticationService() {
            profileRepository =  RepositoryFactory.GetRepository<Profile>(RepositoryType.Profile);
        }

        public Profile Login(string username, string password) { 
            Profile user = ((ProfileRepository) profileRepository).FindByEmail(username);
            if (BCrypt.Net.BCrypt.Verify(password, user.Password))
               return user; // return a profile if the password is correct
            throw new Exception("Invalid password");
        }

        public Profile Register(Profile model)
        {
            try
            {
                ((ProfileRepository) profileRepository).FindByEmail(model.Email);
                throw new Exception("Profile already exists");
            }
            catch (CustomException) { // If the profile does not exist, save it
                model.Password = BCrypt.Net.BCrypt.HashPassword(model.Password, salt);
                return profileRepository.Save(model); 
            }
        }
    }
}
