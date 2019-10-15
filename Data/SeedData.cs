using Books.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Books.Data{

public static class SeedData {
    // this is an extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder) {
        // modelBuilder.Entity<something>().HasData(
        //     'a'//GetTeams()
        // );
    }

    }
}
