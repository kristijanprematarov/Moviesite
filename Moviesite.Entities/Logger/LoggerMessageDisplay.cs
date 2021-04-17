namespace Moviesite.Entities.Logger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class LoggerMessageDisplay
    {
        #region MovieMessages

        public const string MoviesListed = "All movies listed successfully!";
        public const string NoMoviesInDB = "There is no movies in the DB!";
        public const string MovieFoundDisplayDetails = "movie was found in the DB, show the details of the movie";
        public const string NoMovieFound = "This is no movie found in the DB!";
        public const string MovieCreated = "New movie is created in the DB";
        public const string MovieNotCreatedModelStateInvalid = "New movie is NOT created in the DB, ModelState is not valid";
        public const string MovieEdited = "Movie is edited successfully";
        public const string MovieEditNotFound = "Movie for editting is not found in the DB";
        public const string MovieEditErrorModelStateInvalid = "Movie is not edited, ModelState is not valid";
        public const string MovieDeleted = "Movie is deleted successfully";
        public const string MovieDeletedError = "Movie is NOT deleted, error happend in process of deletion";

        #endregion

        #region ProducerMessages

        public const string ProducersListed = "All producers listed successfully!";
        public const string NoProducersInDB = "There is no producers in the DB!";
        public const string ProducerFoundDisplayDetails = "Producer was found in the DB, show the details of the producer";
        public const string NoProducerFound = "This is no producer found in the DB!";
        public const string ProducerCreated = "New producer is created in the DB";
        public const string ProducerNotCreatedModelStateInvalid = "New producer is NOT created in the DB, ModelState is not valid";
        public const string ProducerEdited = "Producer is edited successfully";
        public const string ProducerEditNotFound = "Producer for editting is not found in the DB";
        public const string ProducerEditErrorModelStateInvalid = "Producer is not edited, ModelState is not valid";
        public const string ProducerDeleted = "Producer is deleted successfully";
        public const string ProducerDeletedError = "Producer is NOT deleted, error happend in process of deletion";

        #endregion

        #region ActorMessages

        public const string ActorsListed = "All actors listed successfully!";
        public const string NoActorsInDB = "There is no actors in the DB!";
        public const string ActorFoundDisplayDetails = "Actor was found in the DB, show the details of the actor";
        public const string NoActorFound = "This is no actor found in the DB!";
        public const string ActorCreated = "New actor is created in the DB";
        public const string ActorNotCreatedModelStateInvalid = "New actor is NOT created in the DB, ModelState is not valid";
        public const string ActorEdited = "Actor is edited successfully";
        public const string ActorEditErrorModelStateInvalid = "Actor is not edited, ModelState is not valid";
        public const string ActorDeleted = "Actor is deleted successfully";
        public const string ActorDeletedError = "Actor is NOT deleted, error happend in process of deletion";

        #endregion

        #region GenreMessages

        public const string GenresListed = "All genres listed successfully!";
        public const string NoGenresInDB = "There is no genres in the DB!";
        public const string GenreFoundDisplayDetails = "Genre was found in the DB, show the details of the genre";
        public const string NoGenreFound = "This is no genre found in the DB!";
        public const string GenreCreated = "New genre is created in the DB";
        public const string GenreNotCreatedModelStateInvalid = "New genre is NOT created in the DB, ModelState is not valid";
        public const string GenreEdited = "Genre is edited successfully";
        public const string GenreEditErrorModelStateInvalid = "Genre is not edited, ModelState is not valid";
        public const string GenreDeleted = "Genre is deleted successfully";
        public const string GenreDeletedError = "Genre is NOT deleted, error happend in process of deletion";

        #endregion

        #region UploadPhotoMessages

        public const string PhotoUploaded = "Photo is successfully uploaded";
        public const string PhotoUploadedError = "Photo is NOT uploaded";
        public const string PhotosListed = "All photos listed successfully!";
        public const string NoPhotosInDB = "There is no photos in the DB!";
        public const string PhotoFoundDisplayDetails = "Photo was found in the DB, show the details of the photo";
        public const string NoPhotoFound = "This is no photo found in the DB!";
        public const string PhotoCreated = "New photo is created in the DB";
        public const string PhotoNotCreatedModelStateInvalid = "New photo is NOT created in the DB, ModelState is not valid";
        public const string PhotoEdited = "Photo is edited successfully";
        public const string PhotoEditErrorModelStateInvalid = "Photo is not edited, ModelState is not valid";
        public const string PhotoDeleted = "Photo is deleted successfully";
        public const string PhotoDeletedError = "Photo is NOT deleted, error happend in process of deletion";

        #endregion

        #region UserMessages

        public const string UsersListed = "All users listed successfully!";
        public const string NoUsersInDB = "There is no user in the DB!";
        public const string UserFoundDisplayDetails = "User was found in the DB, show the details of the user";
        public const string NoUserFound = "This is no user found in the DB!";
        public const string UserCreated = "New user is created in the DB";
        public const string UserNotCreatedModelStateInvalid = "New user is NOT created in the DB, ModelState is not valid";
        public const string UserEdited = "User is edited successfully";
        public const string UserEditErrorModelStateInvalid = "User is not edited, ModelState is not valid";
        public const string UserDeleted = "User is deleted successfully";
        public const string UserDeletedError = "User is NOT deleted, error happend in process of deletion";
        public const string UserAddedRole = "Added new role to user";

        #endregion

        #region QuoteMessages

        public const string QuoteAdded = "New quote is added in the DB";
        public const string QuoteNotAdded = "Problem adding the quote in the DB";

        #endregion
    }
}
