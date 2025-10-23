package com.ebootis.spring_boot.repositories;

import com.ebootis.spring_boot.models.Article;
import org.springframework.data.jpa.repository.JpaRepository;

public interface IArticleRepository extends JpaRepository<Article,Integer> {

}
