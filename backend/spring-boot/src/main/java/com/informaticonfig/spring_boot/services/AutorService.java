package com.informaticonfig.spring_boot.services;

import com.informaticonfig.spring_boot.model.Autor;
import com.informaticonfig.spring_boot.repository.AutorsRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class AutorService {

    @Autowired
    private AutorsRepository autorRepo;

    public List<Autor> autorsList(){
        return autorRepo.findAll();
    }

    public Optional<Autor> findID(Integer p_id){
        return autorRepo.findById(p_id);
    }

    public Autor Save(Autor p_autor){
        return autorRepo.save(p_autor);
    }
    public void delete(Integer p_id){
         autorRepo.deleteById(p_id);
    }

}
