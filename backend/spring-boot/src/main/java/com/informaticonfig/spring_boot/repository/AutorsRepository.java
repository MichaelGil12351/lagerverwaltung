package com.informaticonfig.spring_boot.repository;

import com.informaticonfig.spring_boot.model.Autor;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface AutorsRepository extends JpaRepository<Autor,Integer> {
}
