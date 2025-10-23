package com.informaticonfig.spring_boot.controllers;

import com.informaticonfig.spring_boot.model.Book;
import com.informaticonfig.spring_boot.services.BookService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;

@RestController
@RequestMapping("/api/books")
public class BookCtrl {
        @Autowired
        private BookService serv_book;

        @GetMapping
        public ResponseEntity<List<Book>> listAllBooks(){
            List<Book> books = serv_book.autorsList();
            return new ResponseEntity<>(books, HttpStatus.OK);
        }


    @GetMapping("/{id}")
    public ResponseEntity<Book> find(@PathVariable Integer id) {
        Optional<Book> book = serv_book.findID(id);
        return book.map(a -> new ResponseEntity<>(a, HttpStatus.OK))
                .orElseGet(() -> new ResponseEntity<>(HttpStatus.NOT_FOUND));
    }


    @PostMapping
    public ResponseEntity<Book> enterAutor(@RequestBody Book p_book)
    {
        Book m_autor = serv_book.Save(p_book);
        return new ResponseEntity<>(p_book, HttpStatus.CREATED);
    }
    }

