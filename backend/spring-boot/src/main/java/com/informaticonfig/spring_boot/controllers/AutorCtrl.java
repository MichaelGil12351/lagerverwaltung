package com.informaticonfig.spring_boot.controllers;

import com.informaticonfig.spring_boot.model.Autor;
import com.informaticonfig.spring_boot.services.AutorService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;

@RestController
@RequestMapping("/api/autores")
public class AutorCtrl {

    @Autowired
    private AutorService serv_autor;

    @GetMapping("/all")
    public ResponseEntity<List<Autor>> listAllAutors(){
        List<Autor> autors = serv_autor.autorsList();
        return new ResponseEntity<>(autors, HttpStatus.OK);
    }

    @GetMapping("/{id}")
    public ResponseEntity<Autor> find(@PathVariable Integer id) {
        Optional<Autor> autor = serv_autor.findID(id);
        return autor.map(a -> new ResponseEntity<>(a, HttpStatus.OK))
                .orElseGet(() -> new ResponseEntity<>(HttpStatus.NOT_FOUND));
    }

    @PostMapping
    public ResponseEntity<Autor> enterAutor(@RequestBody Autor p_autor)
    {
        Autor m_autor = serv_autor.Save(p_autor);
        return new ResponseEntity<>(m_autor, HttpStatus.CREATED);
    }
}
