package com.ebootis.spring_boot.mappers;

import com.ebootis.spring_boot.dtos.ArticleDTO;
import com.ebootis.spring_boot.models.Article;
import com.ebootis.spring_boot.models.Warehouse;
import com.ebootis.spring_boot.repositories.IWarehouseRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

@Component
public class ArticleMapper implements IMapper<Article, ArticleDTO> {
    @Autowired
    IWarehouseRepository warehouseRepository;
    @Override
    public ArticleDTO toDTO(Article p_articleEntity) {
        if (p_articleEntity == null) return null;

        ArticleDTO articleDTO = new ArticleDTO();
        articleDTO.setId(p_articleEntity.getId());
        articleDTO.setName(p_articleEntity.getName());
        articleDTO.setDescription(p_articleEntity.getDescription());
        articleDTO.setForm(p_articleEntity.getForm());
        articleDTO.setPrice(p_articleEntity.getPrice());
        articleDTO.setCreatedAt(p_articleEntity.getCreatedAt());

        if (p_articleEntity.getStorageLocation() != null) {
            articleDTO.setStorageLocationId(p_articleEntity.getStorageLocation().getId());
        }

        return articleDTO;
    }

    @Override
    public Article toEntity(ArticleDTO articleDTO) {
        Article article = new Article();
        article.setId(articleDTO.getId());
        article.setName(articleDTO.getName());
        article.setDescription(articleDTO.getDescription());
        article.setForm(articleDTO.getForm());
        article.setPrice(articleDTO.getPrice());
        article.setCreatedAt(articleDTO.getCreatedAt());

        if (articleDTO.getStorageLocationId() != null) {
            Warehouse warehouse = warehouseRepository.findById(articleDTO.getStorageLocationId())
                    .orElseThrow(() -> new RuntimeException("Warehouse not found"));
            article.setStorageLocation(warehouse);
        }

        return article;
    }


    public Article toEntityX(ArticleDTO dto, IWarehouseRepository warehouseRepository) {


        Article article = new Article();
        article.setName(dto.getName());
        article.setDescription(dto.getDescription());
        article.setForm(dto.getForm());
        article.setPrice(dto.getPrice());
        article.setCreatedAt(dto.getCreatedAt());

        if (dto.getStorageLocationId() != null) {
            Warehouse warehouse = warehouseRepository.findById(dto.getStorageLocationId())
                    .orElseThrow(() -> new RuntimeException("Warehouse not found"));
            article.setStorageLocation(warehouse);
        }

        return article;
    }

}
