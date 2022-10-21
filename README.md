# IS7024_Project
## Introduction
### Overview
We will be making a movie search application. Users can search for a movie and see its poster along with additional details about the movie like cast, director, and ratings. We'll also allow the users to see a trending list of popular movies.  

### Purpose
The web application is to provide users with the ability to enter a movie title and retrieve information about that film. The scope on a movie can be narrowed by entering specific attributes about a film into the form. These attributes could be genre, year, director, and/or cast members.  

### Scope
The details of the movie that will be provided will include:
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
- Link to Stream/Purchase  

## Logo
### Primary  
![icon_orange](https://user-images.githubusercontent.com/51447959/196820576-432a932f-0646-426a-b126-324a00ec499f.png "Primary Application Logo")  

### Alternative  
![icon_bw](https://user-images.githubusercontent.com/51447959/196820597-9dfebd06-b8f7-45a7-b945-fbaad20bfcad.png  "Secondary Application Logo")  


## Storyboard
![StoryBoard_TopPage](https://user-images.githubusercontent.com/101297146/196309202-df4e5b28-0472-43cf-ab5c-5123df275699.png)

![StoryBoard_MiddlePage](https://user-images.githubusercontent.com/101297146/196309044-de21b5bb-b9de-4bde-b26a-4f7b250df362.png)

![StoryBoard_BottomPage](https://user-images.githubusercontent.com/101297146/196309068-1e3f4b75-d83a-47c0-9f62-c52f3b07c521.png)

## Projects
https://github.com/users/shipleydm/projects/1/views/1

# Functional Requirements
## Requirement 1: Search for Movies
### Scenario
As a user interested in movies, I want to be able to search movies based on movie name or imdb id.

### Dependencies
Movies data is available and accessible.

### Assumptions
Names are stated in English.

### Examples

1.1

**Given** movies data is available
**When**  I search for "Infinity war"
**Then**  I should receive one result which closely matches the title along with these attributes.
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
**Given** movies data is available
**When**  I search for "sklujapouetllkjsda"
**Then**  I should receive zero results (an empty list).

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

