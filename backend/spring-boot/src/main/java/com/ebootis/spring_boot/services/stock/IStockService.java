package com.ebootis.spring_boot.services.stock;

import com.ebootis.spring_boot.dtos.StockDTO;
import com.ebootis.spring_boot.models.Stock;
import com.ebootis.spring_boot.services.generic.ICombinedGenericService;

public interface IStockService extends ICombinedGenericService<Stock,StockDTO,Integer> {

}
