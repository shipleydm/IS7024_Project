# IS7024_Project
## Introduction
### Overview
We will be making a movie search application. Users can search for a movie and see its poster along with additional details about the movie like cast, director, and ratings. We'll also allow the users to see a trending list of popular movies.    

### Purpose
The web application is to provide users with the ability to search for movie information. They might be a cinephile and want to find information related to different movies or want to get ideas of what to watch next.

### Scope
The details of the movie that will be provided will include, but are not limited to:
- Title
- Year
- Director(s)
- Writer(s)
- Rating
- Time
- Genre
- Cast Members
- Awards
- Poster
- Storyline 

## Logo
### Primary  
![icon_orange](https://user-images.githubusercontent.com/51447959/196820576-432a932f-0646-426a-b126-324a00ec499f.png "Primary Application Logo")  

### Alternative  
![icon_bw](https://user-images.githubusercontent.com/51447959/196820597-9dfebd06-b8f7-45a7-b945-fbaad20bfcad.png  "Secondary Application Logo")  


## Storyboard
These storyboards provide a high-level overview of the screen designs we plan to create. Note, for simplicity sake of the designs, not every data attribute we plan to display is shown in each section, these designs were meant to show the general look and feel of the type of information users can expect. Also, there is a legend-key to aid the design visuals, this will not be implemented in the UI.

![StoryBoard_TopPage](https://user-images.githubusercontent.com/101297146/196309202-df4e5b28-0472-43cf-ab5c-5123df275699.png "Screen design of movie info and poster")

![StoryBoard_MiddlePage](https://user-images.githubusercontent.com/101297146/196309044-de21b5bb-b9de-4bde-b26a-4f7b250df362.png "Screen design of an iframe for a movie trailer video")

![StoryBoard_BottomPage](https://user-images.githubusercontent.com/101297146/197305127-c1c90031-d26b-4ce0-bec0-4ca78e868fe9.png "Screen design of movie info related to trending movies")

## Projects
https://github.com/users/shipleydm/projects/1/views/1

# Functional Requirements
## Requirement 1: Search for Movies
### Scenario
As a user interested in movies, I want to be able to search movies based on movie name or imdb id.

### Dependencies
Movie data is available and accessible.

### Assumptions
Names are stated in English.

### Examples

1.1

>**Given** movie data is available.
>
>**When**  I search for "Infinity war".
>
>**Then**  I should receive one result which closely matches the title along with these attributes.

- Title : Avengers: Infinity War
- Year  : 2018
- Director(s) : Anthony Russo, Joe Russo
- Writer(s) : Christopher Markus, Stephen McFeely, Stan Lee
- Rating : 
    Source	:	Internet Movie Database
    Value	:	8.4/10
    Source	:	Rotten Tomatoes
    Value	:	85%
    Source	:	Metacritic
    Value	:	68/100
- Time :  149 min
- Genre :  Action, Adventure, Sci-Fi
- Cast Members : Robert Downey Jr., Chris Hemsworth, Mark Ruffalo
- Awards : Nominated for 1 Oscar. 46 wins & 79 nominations total
- Poster :  https://m.media-amazon.com/images/M/MV5BMjMxNjY2MDU1OV5BMl5BanBnXkFtZTgwNzY1MTUwNTM@._V1_SX300.jpg
- Storyline : The Avengers and their allies must be willing to sacrifice all in an attempt to defeat the powerful Thanos before his blitz of devastation and ruin puts an end to the universe.

1.2 
>**Given** movie data is available.
>
>**When**  I search for "sklujapouetllkjsda".
>
>**Then**  I should receive zero results (an empty list).

1.3
>**Given** movie data is unavailable.
>
>**When**  I search for "infinity war".
>
>**Then**  I should receive an error message with 503 Service Unavailable servor error. Please try again later.

## Requirement 2: View list of trending movies
### Scenario
As a user interested in movies, I want to be able to view a list of trending movies.

### Dependencies
Trending movie data is available and accessible.

### Assumptions
Names are stated in English.

### Examples: 

2.1

>**Given**  trending movie data is available.
>
>**When**  I want to view a list of trending movies. 
>
>**Then**  I should receive results with attributes similar to the following for each movie.

- Title       : Bullet Train
- Language    : en
- Overview    : Unlucky assassin Ladybug is determined to do his job peacefully after one too many gigs gone off the rails. Fate, however, may have other plans, as Ladybug's latest mission puts him on a collision course with lethal adversaries from around the globe—all with connected, yet conflicting, objectives—on the world's fastest train.
- Genre       : Action, Adveture, Thriller
- Poster Path : /tVxDe01Zy3kZqaZRNiXFGDICdZk.jpg
- Popularity  : 2179.463
- Vote Count  : 7.51
- Vote Average: 1890
- Release Date: 2022-07-03

And I should receive at least one result with these attributes:

- Title       : Black Adam
- Language    : en 
- Overview    : Nearly 5,000 years after he was bestowed with the almighty powers of the Egyptian gods—and imprisoned just as quickly—Black Adam is freed from his earthly tomb, ready to unleash his unique form of justice on the modern world.
- Genre       : Action / SuperHero
- Poster Path : /pFlaoHTZeyNkG83vxsAJiGzfSsa.jpg
- Popularity  : 2618.689
- Vote Count  : 166
- Vote Average: 7.53
- Release Date: 2022-10-19

2.2
>**Given**  trending movie data is unavailable.
>
>**When**  I want to view a list of trending movies. 
>
>**Then**  I should receive an error message with 503 Service Unavailable servor error. Please try again later.


### Data Sources
 1) [OMDB API](http://www.omdbapi.com/?apikey=280d36f8&t=infinity+war)
 2) [Streaming Availability](https://streaming-availability.p.rapidapi.com/get/basic?country=us&tmdb_id=movie%2F120&output_language=en)
 3) [Trending Movies](https://api.themoviedb.org/3/trending/movie/week?api_key=641404d7aea85802758ccd6b0857f41a)

## Team Composition
### Team Members
 1) Devops Engineer / Scrum Master - [Darren Shipley](https://github.com/shipleydm)
 2) Front End Engineer - [Jason Day](https://github.com/jasonjday)
 3) Integration Engineer - [Praveen Singi](https://github.com/praveensingi)

### Weekly meeting time and format 
Friday 7:30 PM in Teams

