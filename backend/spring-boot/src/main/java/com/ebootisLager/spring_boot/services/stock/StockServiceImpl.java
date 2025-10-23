package com.ebootis.spring_boot.services.stock;

import com.ebootis.spring_boot.dtos.StockDTO;
import com.ebootis.spring_boot.mappers.IMapper;
import com.ebootis.spring_boot.models.Article;
import com.ebootis.spring_boot.models.Warehouse;
import com.ebootis.spring_boot.models.Stock;
import com.ebootis.spring_boot.repositories.IArticleRepository;
import com.ebootis.spring_boot.repositories.IWarehouseRepository;
import com.ebootis.spring_boot.repositories.IStockRepository;
import com.ebootis.spring_boot.services.generic.CombinedGenericServiceImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class StockServiceImpl extends CombinedGenericServiceImpl<Stock, StockDTO, Integer> implements IStockService {

    private final IArticleRepository articleRepository;
    private final IWarehouseRepository locationRepository;

    @Autowired
    public StockServiceImpl(IStockRepository repository,
                            IMapper<Stock, StockDTO> mapper,
                            IArticleRepository articleRepository,
                            IWarehouseRepository locationRepository) {
        super(repository, mapper);
        this.articleRepository = articleRepository;
        this.locationRepository = locationRepository;
    }

    @Override
    public StockDTO createDTO(StockDTO dto) {
        Stock stock = mapper.toEntity(dto);

        // Asocia Article
        Article article = articleRepository.findById(dto.getArticleId())
                .orElseThrow(() -> new RuntimeException("Artículo no encontrado con ID: " + dto.getArticleId()));
        stock.setArticle(article);

        // Asocia Location
        Warehouse location = locationRepository.findById(dto.getWarehouseId())
                .orElseThrow(() -> new RuntimeException("Ubicación no encontrada con ID: " + dto.getWarehouseId()));
        stock.setWarehouse(location);

        Stock saved = ((IStockRepository) repository).save(stock);
        return mapper.toDTO(saved);

    }
}