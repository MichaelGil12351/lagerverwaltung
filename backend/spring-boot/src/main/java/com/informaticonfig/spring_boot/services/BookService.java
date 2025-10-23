package com.informaticonfig.spring_boot.services;

import com.informaticonfig.spring_boot.model.Autor;
import com.informaticonfig.spring_boot.model.Book;
import com.informaticonfig.spring_boot.repository.BooksRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class BookService {

    @Autowired
    private BooksRepository booksRepo;

    public List<Book> autorsList(){
        return booksRepo.findAll();
    }

    public Optional<Book> findID(Integer p_id){
        return booksRepo.findById(p_id);
    }

    public Book Save(Book p_book){
        return booksRepo.save(p_book);
    }
    public void delete(Integer p_id){
        booksRepo.deleteById(p_id);
    }
}
