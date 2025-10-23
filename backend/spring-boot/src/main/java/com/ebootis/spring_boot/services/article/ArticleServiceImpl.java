package com.ebootis.spring_boot.services.article;

import com.ebootis.spring_boot.dtos.ArticleDTO;
import com.ebootis.spring_boot.mappers.IMapper;
import com.ebootis.spring_boot.models.Article;
import com.ebootis.spring_boot.repositories.IArticleRepository;
import com.ebootis.spring_boot.services.generic.CombinedGenericServiceImpl;
import org.springframework.stereotype.Service;
@Service
public class ArticleServiceImpl extends CombinedGenericServiceImpl<Article, ArticleDTO, Integer> implements IArticleService {

    public ArticleServiceImpl(IArticleRepository repository, IMapper<Article, ArticleDTO> mapper) {
        super(repository, mapper);
    }

}
