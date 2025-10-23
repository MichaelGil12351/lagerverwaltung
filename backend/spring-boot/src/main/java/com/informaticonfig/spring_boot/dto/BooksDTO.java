package com.informaticonfig.spring_boot.dto;

import com.informaticonfig.spring_boot.model.Autor;
import com.informaticonfig.spring_boot.model.Book;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.math.BigDecimal;
import java.time.LocalDate;

@Data
@NoArgsConstructor
public class BooksDTO {
    private Integer id;
    private String titel, editorial, gender;
    private BigDecimal price;
    private LocalDate datumEdit;

    private AutorDTO autorDTO;

    public BooksDTO(Book p_book) {
        this.id = p_book.getId();
        this.titel = p_book.getTitel();
        this.editorial = p_book.getEditorial();
        this.gender = p_book.getGender();
        this.price = p_book.getPrice();
        this.datumEdit = p_book.getDatumEdit();
        autorDTO =  new AutorDTO(p_book.getAutor());
    }
}
