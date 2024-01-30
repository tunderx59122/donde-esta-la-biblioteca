﻿using BusinessObjects.Entity;
using BusinessObjects.Enums;
using DataAccessLayer.Repository;
using DataAccessLayer.Contexts;
using static System.Reflection.Metadata.BlobBuilder;

/// <summary>
/// Summary description for BookRepository
/// </summary>

public class BookRepository : IGenericRepository<Book>
{
    private LibraryContext _libraryContext = new LibraryContext();
    public List<Book> GetAll()
    {
        return _libraryContext._books.ToList();
    }

    public Book Get(int id)
    {
        return _libraryContext._books.Where(x => x.Id.Equals(id)).FirstOrDefault();
    }
}