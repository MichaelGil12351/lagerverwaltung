package com.informaticonfig.spring_boot.model;

import jakarta.persistence.*;
import lombok.*;

import java.math.BigDecimal;
import java.time.LocalDate;

@Data
@NoArgsConstructor
@Entity
public class Book {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;
    private String titel, editorial, gender;
    private BigDecimal price;
    private LocalDate datumEdit;
    @ManyToOne
    private Autor autor;




}
