package com.ebootis.spring_boot.mappers;

import com.ebootis.spring_boot.dtos.StockDTO;
import com.ebootis.spring_boot.models.Stock;
import org.springframework.stereotype.Component;

@Component
public class StockMapper implements IMapper<Stock, StockDTO> {

    @Override
    public StockDTO toDTO(Stock p_stock) {
//        if (p_stock == null) return null;
//
//        StockDTO dto = new StockDTO();
//        dto.setId(p_stock.getId());
//        dto.setQuantity(p_stock.getQuantity());
//
//        if (p_stock.getArticle() != null) {
//            dto.setArticleId(p_stock.getArticle().getId());
//        }
//        if (p_stock.getWarehouse() != null) {
//            dto.setLocationId(p_stock.getWarehouse().getId());
//        }
//
        return null;
    }

    @Override
    public Stock toEntity(StockDTO dto) {
//        if (dto == null) return null;
//
//        Stock stock = new Stock();
//        stock.setId(dto.getId());
//        stock.setQuantity(dto.getQuantity());
//
//        // Nota: NO se asignan aquí Article ni Location,
//        // eso se hace en el servicio usando los repositorios.

        return null;
    }
}