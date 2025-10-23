package com.ebootis.spring_boot.controlls;

import com.ebootis.spring_boot.dtos.ProcessPositionDTO;
import com.ebootis.spring_boot.services.processPosition.ProcessPositionServiceImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/processPosition")
public class ProcessPositionCtrl {

    @Autowired
    private ProcessPositionServiceImpl processPositionService;

    @PostMapping
    public ResponseEntity<ProcessPositionDTO> createProcessPosition(@RequestBody ProcessPositionDTO dto) {
        ProcessPositionDTO created = processPositionService.createDTO(dto);
        return new ResponseEntity<>(created, HttpStatus.CREATED);
    }

    @GetMapping("/{id}")
    public ResponseEntity<ProcessPositionDTO> getProcessPositionById(@PathVariable Integer id) {
        return processPositionService.getDTOById(id)
                .map(ResponseEntity::ok)
                .orElseGet(() -> ResponseEntity.notFound().build());
    }

    @GetMapping("/all")
    public ResponseEntity<List<ProcessPositionDTO>> getAllProcessPositions() {
        List<ProcessPositionDTO> list = processPositionService.getAllDTO();
        if (list.isEmpty()) {
            return ResponseEntity.noContent().build();
        }
        return ResponseEntity.ok(list);
    }
}
