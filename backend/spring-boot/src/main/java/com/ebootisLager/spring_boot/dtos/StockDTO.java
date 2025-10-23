package com.ebootis.spring_boot.dtos;

import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@NoArgsConstructor
public class StockDTO {
    private Integer id;
    private Integer quantity;
    private Integer articleId;
    private String articleName;
    private Integer warehouseId;
    private String warehouseName;
}
