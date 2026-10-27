# Movie Database (WinForms)

A desktop app for searching films and viewing their details. I built it in August 2018 while studying C# at STEP IT Academy, as practice with REST APIs and JSON.

## Features

- Search for films by title
- Results list showing title and year
- A details window with poster, release date, runtime, genre, age rating, director, writers, actors, plot and IMDb rating

## Tech stack

C#, Windows Forms, .NET Framework 4.6.1, Newtonsoft.Json, [OMDb API](https://www.omdbapi.com/)

## How it works

`Form1` sends a search request to OMDb and builds a list of `Movie` objects (IMDb ID, title, year). When you open a film, `FormMoreInfo` requests the full record by its IMDb ID and fills in the form.

## How to run

1. Get a free key at [omdbapi.com](https://www.omdbapi.com/apikey.aspx) and put it in `Form1.cs` and `FormMoreInfo.cs`.
2. Open `MovieDatabaseWinForms.sln` in Visual Studio, restore NuGet packages and press F5.

## Status

This is a learning project from 2018 and is no longer maintained.
