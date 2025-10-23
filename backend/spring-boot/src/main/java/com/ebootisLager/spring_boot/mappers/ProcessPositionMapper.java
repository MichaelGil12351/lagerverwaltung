package com.ebootis.spring_boot.mappers;

import com.ebootis.spring_boot.dtos.ProcessPositionDTO;
import com.ebootis.spring_boot.models.Article;
import com.ebootis.spring_boot.models.ProcessPosition;
import com.ebootis.spring_boot.models.Warehouse;
import com.ebootis.spring_boot.repositories.IArticleRepository;
import com.ebootis.spring_boot.repositories.IWarehouseRepository;
import org.springframework.stereotype.Component;



    @Component
    public class ProcessPositionMapper implements IMapper<ProcessPosition, ProcessPositionDTO> {

        private final IArticleRepository articleRepository;
        private final IWarehouseRepository warehouseRepository;

        public ProcessPositionMapper(IArticleRepository articleRepository, IWarehouseRepository warehouseRepository) {
            this.articleRepository = articleRepository;
            this.warehouseRepository = warehouseRepository;
        }

        @Override
        public ProcessPositionDTO toDTO(ProcessPosition entity) {
            if (entity == null) return null;

            ProcessPositionDTO dto = new ProcessPositionDTO();
            dto.setId(entity.getId());
            dto.setQuantity(entity.getQuantity());
            dto.setTimestamp(entity.getTimestamp());
            dto.setArticleId(entity.getArticle() != null ? entity.getArticle().getId() : null);
            dto.setSourceLocationId(entity.getSourceLocation() != null ? entity.getSourceLocation().getId() : null);
            dto.setTargetLocationId(entity.getTargetLocation() != null ? entity.getTargetLocation().getId() : null);
            return dto;
        }

        @Override
        public ProcessPosition toEntity(ProcessPositionDTO dto) {
            if (dto == null) return null;

            ProcessPosition entity = new ProcessPosition();
            entity.setId(dto.getId());
            entity.setQuantity(dto.getQuantity());
            entity.setTimestamp(dto.getTimestamp());
            if (dto.getArticleId() != null) {
                entity.setArticle(articleRepository.findById(dto.getArticleId())
                        .orElseThrow(() -> new RuntimeException("Article not found: " + dto.getArticleId())));
            }
            entity.setSourceLocation(warehouseRepository.findById(dto.getSourceLocationId()).orElse(null));
            entity.setTargetLocation(warehouseRepository.findById(dto.getTargetLocationId()).orElse(null));
            return entity;
        }
    }


