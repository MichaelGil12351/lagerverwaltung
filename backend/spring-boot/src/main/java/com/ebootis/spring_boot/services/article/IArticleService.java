package com.ebootis.spring_boot.services.article;

import com.ebootis.spring_boot.dtos.ArticleDTO;
import com.ebootis.spring_boot.models.Article;
import com.ebootis.spring_boot.services.generic.ICombinedGenericService;


public interface IArticleService extends ICombinedGenericService<Article,ArticleDTO,Integer> {

}
