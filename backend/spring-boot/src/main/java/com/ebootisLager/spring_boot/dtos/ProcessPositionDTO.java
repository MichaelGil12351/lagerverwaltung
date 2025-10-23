package com.ebootis.spring_boot.dtos;

import lombok.Data;
import lombok.NoArgsConstructor;

import java.time.OffsetDateTime;

@Data
@NoArgsConstructor
public class ProcessPositionDTO {
    private Integer id;
    private Integer quantity;
    private Integer articleId;
    private Integer sourceLocationId;
    private Integer targetLocationId;
    private OffsetDateTime timestamp;
}
