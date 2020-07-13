using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup2
{
    static class Library
    {
        public static List<Media> media = new List<Media>()
        {
            new Book("The White Tiger","Book"),
            new Book("The Guide","Book"),
            new Book("A Fine Balance","Book"),
            new Book("A Suitable Boy","Book"),
            new Book("War and Peace","Book"),

            new Magazine("India Today"),
            new Magazine("The Woman"),
            new Magazine("FilmFair"),
            new Magazine("Vogue India"),
            new Magazine("SportStar"),

            new Movie("Avengers Endgame"),
            new Movie("Toy Story 4"),
            new Movie("Get Out"),
            new Movie("Joker"),
            new Movie("The Godfather"),
        };

        public static List<LibraryMember> member = new List<LibraryMember>()
        {
             new LibraryMember("Keyur"),
             new LibraryMember("Karan"),
             new LibraryMember("Urvish"),
             new LibraryMember("Nisarg"),
             new LibraryMember("Malav"),
        };
    }
}
