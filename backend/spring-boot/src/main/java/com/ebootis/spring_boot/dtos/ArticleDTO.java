// ArticleDTO.java
package com.ebootis.spring_boot.dtos;

import lombok.Data;
import lombok.NoArgsConstructor;
import java.time.OffsetDateTime;

@Data
@NoArgsConstructor
public class ArticleDTO {
    private Integer id;
    private String name;
    private String description;
    private String form;
    private Integer price;
    private OffsetDateTime createdAt;
    private Integer storageLocationId;
    private String storageLocationName;
}
